# $FreeBSD$

PORTNAME=	context-animation
PORTVERSION=	20150412
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Generate fieldstack based animation with ConTeXt.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/bibtex/bst/context/cont-ab.bst:${PORTSDIR}/print/texlive-context

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
