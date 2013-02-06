# $FreeBSD$

PORTNAME=	context-rst
PORTVERSION=	20120730
PORTREVISION=	1
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Process reStructuredText with ConTeXt.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/bibtex/bst/context/cont-ab.bst:${PORTSDIR}/print/texlive-context

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
