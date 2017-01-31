# $FreeBSD$

PORTNAME=	latexmk
PORTVERSION=	20170131
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Fully automated LaTeX document generation

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS SRCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
