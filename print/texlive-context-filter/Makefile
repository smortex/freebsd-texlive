# $FreeBSD$

PORTNAME=	context-filter
PORTVERSION=	20130115
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Run external programs on the contents of a start-stop environment.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/bibtex/bst/context/cont-ab.bst:${PORTSDIR}/print/texlive-context

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
