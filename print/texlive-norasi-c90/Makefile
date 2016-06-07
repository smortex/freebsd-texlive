# $FreeBSD$

PORTNAME=	norasi-c90
PORTVERSION=	20160414
PORTEPOCH=	1
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	TeX support (from CJK) for the norasi font

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/latex/fonts-tlwg/fonts-tlwg.sty:${PORTSDIR}/print/texlive-fonts-tlwg

OPTIONS_DEFINE=	SRCS
OPTIONS_EXCLUDE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
