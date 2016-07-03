# $FreeBSD$

PORTNAME=	ptex
PORTVERSION=	20160701
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	A TeX system for publishing in Japanese

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/ptex/ptex-base/ascii-jplain.tex:${PORTSDIR}/print/texlive-ptex-base \
		${LOCALBASE}/share/texmf-dist/fonts/source/ptex-fonts/ascgrp/ascgrp.mf:${PORTSDIR}/print/texlive-ptex-fonts \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
