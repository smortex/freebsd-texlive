# $FreeBSD$

PORTNAME=	kotex-utils
PORTVERSION=	20150205
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Utility scripts and support files for typesetting Korean.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/latex/kotex-utf/contrib/dhucs-cmap.sty:${PORTSDIR}/print/texlive-kotex-utf \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
