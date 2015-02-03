# $FreeBSD$

PORTNAME=	context-visualcounter
PORTVERSION=	20150202
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	The context-visualcounter package

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/bibtex/bst/context/cont-ab.bst:${PORTSDIR}/print/texlive-context

OPTIONS_DEFINE=	DOCS SRCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
