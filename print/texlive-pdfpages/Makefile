# $FreeBSD$

PORTNAME=	pdfpages
PORTVERSION=	20160421
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Include PDF documents in LaTeX

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/latex/eso-pic/eso-pic.sty:${PORTSDIR}/print/texlive-eso-pic

OPTIONS_DEFINE=	DOCS SRCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
