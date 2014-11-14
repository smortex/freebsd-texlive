# $FreeBSD$

PORTNAME=	context-letter
PORTVERSION=	20141113
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Context package for writing letters.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/bibtex/bst/context/cont-ab.bst:${PORTSDIR}/print/texlive-context

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
